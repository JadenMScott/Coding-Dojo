from django.shortcuts import render, HttpResponse

def index(request):
    return render(request, 'dojos_ninjas_app/index.html') 
