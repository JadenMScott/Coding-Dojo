from django.shortcuts import render
from time import gmtime,strftime
# Create your views here.
def index(request):
    context={
        "time":strftime("%Y-%m-%d %H %M %p",gmtime())
    }
    return render(request,'TDP_App/index.html',context)