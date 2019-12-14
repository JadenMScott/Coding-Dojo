from django.shortcuts import render

# Create your views here.
def index(request):
    return render(request, "books_authors_temp_app/index.html")