from flask import Flask, render_template, request , redirect, session
app = Flask(__name__)   
app.secret_key = "bababooey"


@app.route('/')          
def Counter():
    session['num'] = request.h2['num']
    return render_template("index.html")
    

@app.route('/destroy_session')
def destroy():
    del session ['num']
    return redirect('/')



if __name__=="__main__":
    app.run(debug=True)    

