SELECT last_name, first_name, middle_name, birth_date, group_name, direction_name 
FROM Students, Directions, Groups 
WHERE [group]=group_id AND direction=direction_id 
AND (last_name LIKE (%К%) OR first_name LIKE (%К%) OR middle_name LIKE (%К%));