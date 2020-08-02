from blog.models import Post
from django.contrib.auth.models import User
user = User.objects.get(username='admin')
post = Post(title='Another post',
            slug='another-post',
            body='Post body.',
            author=user)
post.save()