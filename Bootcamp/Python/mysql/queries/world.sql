-- 1. What query would you run to get all the countries that speak Slovene? Your query should return the name of the country, language and language percentage. Your query should arrange the result by language percentage in descending order.

SELECT countries.name, languages.language, languages.percentage
FROM countries JOIN languages ON countries.code = languages.country_code WHERE language = 'Slovene';

-- 2. What query would you run to display the total number of cities for each country? Your query should return the name of the country and the total number of cities. Your query should arrange the result by the number of cities in descending order. (3)

SELECT countries.