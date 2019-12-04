using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist mountVernon= Artists.FirstOrDefault(homeTown=> homeTown.Hometown=="Mount Vernon");

            //Who is the youngest artist in our collection of artists?
            Artist bby= Artists.OrderBy(art=>art.Age).FirstOrDefault();
            //Display all artists with 'William' somewhere in their real name
            IEnumerable<Artist> william =Artists.Where(art=>art.RealName.Contains("William"));
            //Display the 3 oldest artist from Atlanta
            IEnumerable<Artist> atlanteans = Artists.Where(art=>art.Hometown=="Atlanta").OrderByDescending(art=>art.Age).Take(3);
            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            IEnumerable<Group> notNY=Groups.Join(Artists, gr=>gr.Id, art => art.GroupId,(gr,art)=> {
                gr.Members.Add(art);
                return gr;
                }).Where(gr => gr.Members.All(art=> art.Hometown != "New York City")).Distinct();
            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            IEnumerable<Group> wutang=Groups.Join(Artists, gr=>gr.Id, art => art.GroupId,(gr,art)=> {
                gr.Members.Add(art);
                return gr;
                }).Distinct();



            Console.WriteLine(Groups.Count);
            Console.WriteLine(mountVernon.RealName);
            Console.WriteLine(mountVernon.Age);
            Console.WriteLine($"{bby.RealName},{bby.Age},{bby.ArtistName}");
            foreach(Artist will in william){
                Console.WriteLine($"{will.RealName}");
            }
            foreach(Artist atl in atlanteans){
                Console.WriteLine($"{atl.ArtistName}({atl.RealName})-{atl.Age}");
            }
            foreach(Group meme in notNY){
                Console.WriteLine($"{meme.GroupName}");
            }
            foreach(var gr in wutang){
                if( gr.GroupName =="Wu-Tang Clan"){
                    foreach(Artist meme in gr.Members){
                        Console.WriteLine($"{meme.ArtistName}-{meme.RealName}");
                    }
                }
            }
        }
    }
}
