from flask_app.config.mysqlconnection import connectToMySQL
from flask_app import DATABASE
from flask import flash
from flask_app.models import user_model 

class Sighting:
    def __init__(self, data):
        self.id = data['id']
        self.location = data['location']
        self.info = data['info']
        self.date = data['date']
        self.amount = data['amount']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']
        self.user_id = data['user_id']
    

    @classmethod
    def create(cls, data):
        query ="INSERT INTO sightings (location, info, date, amount, user_id) VALUES (%(location)s, %(info)s, %(date)s, %(amount)s, %(user_id)s);"
        return connectToMySQL(DATABASE).query_db(query, data)


    @classmethod
    def get_by_id(cls, data):
        query = "SELECT * FROM sightings JOIN users on users.id = sightings.user_id WHERE sightings.id = %(id)s;"
        results =  connectToMySQL(DATABASE).query_db(query, data)
        if len(results) < 1:
            return False
        row = results[0]
        print(row)
        this_sighting = cls(row)
        user_data = {
            **row, 
            'id': row['users.id'],
            'created_at': row['users.created_at'],
            'updated_at': row['users.updated_at']
        }
        planner = user_model.User(user_data)
        this_sighting.planner = planner
        return this_sighting


    @classmethod
    def update(cls, data):
        query = "UPDATE sightings SET location = %(location)s, info = %(info)s, date = %(date)s, amount = %(amount)s WHERE id = %(id)s; "
        return connectToMySQL(DATABASE).query_db(query, data)

    @classmethod 
    def get_all(cls):
        query = "SELECT * FROM sightings JOIN users on sightings.user_id = users.id;"
        results = connectToMySQL(DATABASE).query_db(query)
        if len(results) > 0:
            all_sightings = []
            for row in results:
                this_sighting = cls(row)
                user_data = {
                    **row, 
                    'id': row['users.id'],
                    'created_at': row['users.created_at'],
                    'updated_at': row['users.updated_at']
                }
                this_user = user_model.User(user_data)
                this_sighting.planner = this_user
                all_sightings.append(this_sighting)
            return all_sightings
        return []


    @classmethod
    def delete(cls, data):
        query = "DELETE FROM sightings WHERE id = %(id)s"
        return connectToMySQL(DATABASE).query_db(query, data)

    @staticmethod
    def validation(form_data):
        is_valid = True
        if len(form_data['location']) < 1:
            flash("Location Required")
            is_valid = False
        
        if len(form_data['info']) < 1:
            flash("What Happened?")
            is_valid = False
        
        if len(form_data['date']) < 1:
            flash("When did it happen")
            is_valid = False
        
        if len(form_data['amount']) < 1:
            flash("amount of times seen?")
            is_valid = False
        return is_valid
