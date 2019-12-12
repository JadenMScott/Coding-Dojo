from flask import Flask
app=Flask(__name__)

@app.route('/')
def HelloWorld():
    return "Hello World!"

@app.route('/dojo')
def dojo():
    return "Dojo!"

@app.route('/say/flask')
def sayflask():
    return "Hi FLask!"

@app.route('/say/michael')
def saymichael():
    return "Hi Michael!"

@app.route('/say/john')
def sayjohn():
    return "Hi John!"

@app.route('/repeat/35/hello')
def hello35():
    return "Hello " * int(35)

@app.route('/repeat/80/bye')
def bye80():
    return "Bye " * int(80)

@app.route('/repeat/99/dogs')
def dogs99():
    return "dogs " * int(99)


if __name__=="__main__":
    app.run(debug=True)