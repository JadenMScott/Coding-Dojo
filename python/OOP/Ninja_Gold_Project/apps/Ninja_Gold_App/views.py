from django.shortcuts import render,redirect,HttpResponse
import random
# Create your views here.

def index(request):
    if "gold" not in request.session:
        request.session['gold']=0
    return render(request,"Ninja_Gold_App/index.html")

def process_money(request):
    # farm earns 10-20 gold
    print(request.POST)
    if request.POST['building']=='farm':
        request.session['gold']+=random.randint(10,20)
        print(request.session['gold'])
        return redirect("/")
    # cave earns 5-10 gold
    elif request.POST['building']=='cave':
        request.session['gold']+=random.randint(5,10)
        return redirect("/")
    # house earns 2-5 gold
    elif request.POST['building']=='house':
        request.session['gold']+=random.randint(2,5)
        return redirect("/")
    # casino either gives or takes anywhere from 0-50 gold
    elif request.POST['building']=='casino':
        determiner=random.randint(0,1)
        if determiner==1:
            request.session['gold']-=100
            request.session['gold']+=random.randint(50,500)
            return redirect("/")
        else:
            request.session['gold']-=100
            request.session['gold']-=random.randint(50,500)
            return redirect("/")
    else:
        print("something went wrong")
        return redirect("/")