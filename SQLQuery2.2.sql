-------2.2------

--1
SELECT *
FROM Employees
WHERE emp_name LIKE '%m%';

--2
SELECT dept_id, MAX(salary)
FROM Employees
GROUP BY dept_id;

--3
WITH Duplicate AS 
(
	SELECT salary
	FROM Employees
	GROUP BY salary
	HAVING COUNT(*) > 1
)
SELECT emp_name, salary
FROM Employees
WHERE salary IN (SELECT salary FROM Duplicate)
ORDER BY salary
