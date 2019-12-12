from flask import Flask, render_template
app = Flask(__name__)

@app.route('/play')
def welcome():
    return render_template("index.html",color="blue",times=3)
    
@app.route('/play/<times>')
def box(times):
    return render_template("index.html",color="blue",times=int(times))

@app.route('/play/<color>/<times>')
def manybox(color,times):
    return render_template("index.html",color=(color),times=int(times))

if __name__=="__main__":
    app.run(debug=True)