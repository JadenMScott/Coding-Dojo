from flask import Flask, render_template
app = Flask(__name__)

@app.route('/')
def hello_world():
   #return render_template("index.html")

@app.route('/success')
def success():
    return "success"

@app.route('/jedi/<name>')
def WelcomeJedi(name):
    print (name)
    return "Welcome "+name +" to the Jedi Database"

@app.route('/hello/<name>')
def hello(name):
    print(name)
    return "Hello " + name

@app.route('/users/<username>/<id>')
def show_user_profile(username,id):
    print(username)
    print(id)
    return "username: " +username + ", id: "+id

# <h3>My Flask Template</h3>
# <p>Phrase: {{ phrase }}</p>
# <p>Times: {{ times }}</p>
      
# {% for x in range(0,times): %}
#     <p>{{ phrase }}</p>
# {% endfor %}
      
# {% if phrase == "hello" %}
#   <p>The phrase says hello</p>
# {% endif %}

if __name__=="__main__":
    app.run(debug=True)