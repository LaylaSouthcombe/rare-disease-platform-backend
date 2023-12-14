from django.shortcuts import render, HttpResponse
from .models import Account

# Create your views here.
def home(request):
    accounts = Account.objects.all()
    print(accounts)
    return HttpResponse("hello world")
