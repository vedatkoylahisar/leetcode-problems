/* Write your T-SQL query statement below */
-- Person tablosuna veri ekle
-- INSERT INTO Person (personId, lastName, firstName)
-- VALUES
--     (1, 'Wang', 'Allen'),
--     (2, 'Alice', 'Bob');

-- -- Address tablosuna veri ekle
-- INSERT INTO Address (addressId, personId, city, state)
-- VALUES
--     (1, 2, 'New York City', 'New York'),
--     (2, 3, 'Leetcode', 'California');

SELECT 
    p.firstName,
    p.lastName,
    a.city,
    a.state
FROM 
    Person p
LEFT JOIN 
    Address a ON p.personId  = a.personId ;

