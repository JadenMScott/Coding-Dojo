from flask import Flask,render_template
app=Flask(__name__)

@app.route('/')
#should display an 8*8 checkerboard
def check(square):
    return render_template("index.html",square=(square))

@app.route('/4')
#should display an 8*4 checkerboard
def checker(x,y):
    return render_template("index.html", x =int(x),y=int(y))

@app.route('/<x>/<y>')
#should return whatever dimension checkerboard is requested by user
def checkerboard(x,y):
    return render_template("index.html",x=int(x),y=int(y))

if __name__=="__main__":
    app.run(debug=True)