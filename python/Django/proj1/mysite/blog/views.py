from django.shortcuts import render, get_object_or_404
from .models import Post
from django.core.paginator import Paginator, EmptyPage, PageNotAnInteger
import json
from django.views.generic import ListView

# def post_list(request):
#     posts = Post.published.all()
#     return render(request,
#                     'blog/post/list.html',
#                     {'posts': posts})


# ------------------------paginator------------------------------

# def post_list(request):
#     object_list = Post.published.all()
#     paginator = Paginator(object_list, 3)  # 3 posts in each page
#     page = request.GET.get('page')
#     try:
#         posts = paginator.page(page)
#     except PageNotAnInteger:
#         # If page is not an integer deliver the first page
#         posts = paginator.page(1)
#     except EmptyPage:
#         # If page is out of range deliver last page of results
#         posts = paginator.page(paginator.num_pages)
#     return render(request,
#                   'blog/post/list.html',
#                   {'page': page,
#                    'posts': posts})

# ------------------------------------------------------------
class PostListView(ListView):
    queryset = Post.published.all()
    context_object_name = 'posts'
    paginate_by = 3
    template_name = 'blog/post/list.html'
# ----------------------------------------------------------------------------------

def post_detail(request, year, month, day, post):
    post = get_object_or_404(Post, slug=post,
                             status='published',
                             publish__year=year,
                             publish__month=month,
                             publish__day=day)
    return render(request,
                  'blog/post/detail.html',
                  {'post': post})


def index(request):
    p1 = MyClass()
    p1.x = 25000
    p1.name = 'My Laptop' 
    p1.nameLen = len(p1.name)
    p1.processor = 'Intel Core'
    p1.arr= ["apple", "banana", "cherry"] 
    
    p1.object_list = Post.published.get(id=1)

    # to_python = json.dumps(p1.__dict__)

    
    return render(request, 'blog/post/index.html', {'model': p1})


class MyClass:
    x = 5

