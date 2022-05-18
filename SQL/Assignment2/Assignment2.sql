--1. Retrieve a list of MANAGERS
--SOLUTION

SELECT ENAME,JOB
FROM EMP 
WHERE JOB ='MANAGER'

--2. Find out salary of both MILLER and SMITH.
--SOLUTION

SELECT ENAME,SAL
FROM EMP
WHERE ENAME IN ('MILLER','SMITH')

--3. Find out the names and salaries of all employees earning more than 1000 per month.
--SOLUTION

SELECT ENAME, SAL
FROM EMP 
WHERE SAL>1000 

--4. Display the names and salaries of all employees except JAMES.
--SOLUTION

SELECT ENAME, SAL 
FROM EMP
WHERE ENAME!='JAMES'

--5. Find out the details of employees whose names begin with ‘S’.
--SOLUTION

SELECT * 
FROM EMP 
WHERE ENAME LIKE 's%'

--6. Find out the names of all employees that have ‘A’ anywhere in their name.
--SOLUTION

SELECT ENAME
FROM EMP
WHERE ENAME LIKE '%A%'

--7. Find out the names of all employees that have ‘L’ as their third character in their name.
--SOLUTION

SELECT ENAME
FROM EMP
 WHERE ENAME LIKE '__L%'

 --8. Find out the names of the employees whose name begin with ‘A’ or ‘M’.
 --SOLUTION

SELECT ENAME 
FROM EMP
WHERE ENAME LIKE 'A%' OR ENAME LIKE 'M%'

--9. Compute yearly salary of SMITH.
--SOLUTION

SELECT SAL*12 AS "SMITH_YEARLY_SALARY" 
FROM EMP 
WHERE ENAME ='SMITH'

--10. Compute daily salary of JONES.
--SOLUTION

SELECT SAL/30 
FROM EMP 
WHERE ENAME ='JONES'

--11. Calculate the total monthly salary of all employees.
--SOLUTION

SELECT SUM(SAL) AS "MONTHLY_SAL_OF_ALL_EMPLOYEES"
FROM EMP 

--12. Print the average annual salary.
--SOLITION

SELECT AVG(SAL*12) AS "AVG_ANNUAL_SALARY"
FROM EMP

--13. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
--SOLUTION

SELECT ENAME,JOB,SAL,DEPTNO 
FROM EMP 
WHERE JOB != 'SALESMAN' AND DEPTNO =30

--14. List unique departments of the EMP table.
--SOLUTION

SELECT DEPTNO
FROM EMP
GROUP BY DEPTNO

--15. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
--SOLUTION

SELECT ENAME AS "EMPLOYEE_NAME",SAL AS "SALARY"
FROM EMP 
WHERE SAL >1500 AND DEPTNO IN (10,30)


