from django.shortcuts import render,redirect
from django.utils.crypto import get_random_string

# Create your views here.
def index(request):

    request.session['counter']=0
    return render(request,'RWG_App/index.html')

def generate(request):
    if request.POST['butt']=="true":
        request.session['word']=get_random_string(length=10)
        request.session['counter']+=1
    return redirect("/")

def clear(request):
    request.session['counter']=0
    return redirect("/")