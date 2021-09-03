SELECT Customer_Id, C.Name, M.Name, SUM(Amout) AS Total
From ORDERS AS O
LEFT JOIN CUSTOMERS AS C ON O.Customer_Id = C.Id 
LEFT JOIN MANAGERS AS M ON C.Manager_Id = M.Id 
WHERE Date > '2013-01-01'
GROUP BY Customer_Id, C.Name, M.Name
HAVING SUM(Amout) > 10000