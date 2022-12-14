from flask_app.config.mysqlconnection import connectToMySQL
from flask_app import DATABASE
from flask import flash
from flask_app.models import user_model


class Party:
    def __init__(self,data):
        self.id = data['id']
        self.what = data['what']
        self.where = data['where']
        self.date = data['date']
        self.all_ages = data['all_ages']
        self.description = data['description']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']
        self.user_id = data['user_id']

#CREATE
    @classmethod
    def create (cls, data):
        query = "INSERT INTO parties (what, where, date, all_ages, description, user_id) VALUES ( %(what)s, %(where)s, %(date)s, %(all_ages)s, %(description)s, %(user_id)s );"
        return connectToMySQL(DATABASE).query_db(query, data)

    
    @classmethod
    def get_all (cls, data):
        query = "SELECT * FROM parties Join user on parties.user_id = users.id"
        results = connectToMySQL(DATABASE).query_db(query, data)
        if results:
            all_parties = []
            for row in results: 
                this_party = cls(row)
                user_data = {
                    **row,
                    'id': row['users.id'],
                    'created_at': row['users.created_at'],
                    'updated_at': row['users.updated_at']
                    }
                this_user = user_model.User(user_data)
                this_party.planner = this_user
                all_parties.append(this_party)
            return all_parties
        return []