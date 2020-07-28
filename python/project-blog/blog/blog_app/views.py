from django.shortcuts import render
from .models import Post



def blog_list(request):
    print("ddddddddddddddddddddddddddd")

    post = Post.objects.all()


    txt = "wss"
    o ="sssstttsssss"
    w ="ett"
    context= {
        'blog_list':post,
        'text':txt,
        't': o,
        'wq':w
    }      

    return render(request,"blog/blog_list.html",context)
#-------------------------------------------------------------------