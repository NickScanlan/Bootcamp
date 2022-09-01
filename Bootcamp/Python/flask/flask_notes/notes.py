"""
    virtual environments: used to control evrsions of our packages for our apps, walled off from the rest of our computer
    
    step 0: pip install pipenv - we run this ONCE to install it to our computer globally (does not matter where you run)
    
    step 0.1: python -m pipenv
    
    step 1: open cmder and navigate to the folder we will be working in
    
    step 2 :in cmder, run: pipenv install flask   
    this creates our virtual environment in the folder, and also installs flask
    
    step 3: in cmder, run: pipenv shell
    this makes our cmder enter the virtual environment
    
    step 4: in cmder, run: python server.py
    usually the file we're going to run is called server.py
    
    step 5: to exit server.py and return to the shell, we need to hit CTRL+C
    
    step 6: then we can run exit to leave the shell
    when were done working in the environment we run exit to leave
"""


"""
virtual environments: used to control versions of our packages for our apps, walled off from the rest of our computer
pip install pipenv
pip3 install pipenv
install pipenv -- run this once ever to globally install pipenv
python -m pipenv <command to use>
python3 -m pipenv <command to use>
may have to run pipenv commands like above depending on your computer set up
pipenv install flask
this command creates a new virtual environment and installs flask to it
exit
leaves virtual environmnt
"""