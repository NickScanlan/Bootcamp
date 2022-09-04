from flask import Flask, render_template, session, redirect
app = Flask(__name__)   
app.secret_key = "bababooey"

@app.route('/')
def home():
    if 'bababooey' in session:  
        session['count'] = 0
    session['count'] += 0
    return render_template('index.html', count = session['count'])




@app.route('/add')
def add():
    print('this is the counter page')
    session['count'] += 1
    return redirect('/')


@app.route('/destroy')
def reset():
    session['count'] = 1
    return redirect('/') 



if __name__=="__main__":
    app.run(debug=True)    

