USE PD_311;

SELECT group_name, COUNT(student_id), direction_name 
FROM Groups, Directions, Students 
WHERE direction=direction_id AND [group]=group_id GROUP BY [group_name], direction_name;