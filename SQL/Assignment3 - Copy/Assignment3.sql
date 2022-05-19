--1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
--SOLUTION

SELECT ENAME, SAL 
FROM EMP
WHERE SAL NOT BETWEEN 1500 AND 2850

--2. Display the name and job of all employees who do not have a MANAGER.
--SOLUTION
SELECT * FROM EMP
SELECT ENAME,JOB 
FROM EMP 
WHERE MGR = NULL

--3. Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000.
--SOLUTION

SELECT ENAME,JOB,SAL
FROM EMP
WHERE JOB IN ('MANAGER','ANALYST') AND SAL NOT IN (1000,3000,5000)

--4. Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%.

SELECT ENAME,SAL+SAL*10/100 AS "SALARY_INCREASED_BY10%" ,COMM 
FROM EMP
WHERE COMM > SAL

--5. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
--SOLUTION

SELECT ENAME 
FROM EMP
WHERE ENAME LIKE '%L%L%' AND  DEPTNO=30 OR MGR = 7782

--6. Display the names of employees with experience of over 10 years and under 20 yrs.Count the total number of employees.
 --SOLUTION

SELECT COUNT(*) AS "NO.OF_EMPLOYEES", ENAME 
FROM EMP
WHERE  CONVERT(VARCHAR(3),DATEDIFF(YEAR,HIREDATE,GETDATE()))>10 AND CONVERT(VARCHAR(3),DATEDIFF(YEAR,HIREDATE,GETDATE()))>20
GROUP BY ENAME

--7. Retrieve the names of departments in ascending order and their employees in descending order.
--SOLUTION

SELECT DNAME, ENAME
FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO 
ORDER BY DNAME ASC,ENAME DESC

--8. Find out experience of MILLER.
--SOLUTON

SELECT DATEDIFF(YY,'1982/01/23','2022/05/18') AS "EXPERIENCE_MILLER_IN_YEARS"

--9. How many different departments are there in the employee table.
--SOLUTION

SELECT COUNT(DEPTNO) AS "DIFFERENT_DEPARTMENT",DEPTNO
FROM EMP
GROUP BY DEPTNO
 
--10. Find out which employee either work in SALES or RESEARCH department. 
--SOLUTION

SELECT ENAME, DNAME
FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO
WHERE EMP.DEPTNO IN (SELECT DEPTNO 
				 FROM DEPT
				 WHERE DNAME IN ('SALES','RESEARCH'))

				 --OR--

SELECT ENAME,DNAME  
FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO
WHERE DNAME IN ('SALES','RESEARCH')

--11. Print the name and average salary of each department.
--SOLUTION

SELECT DNAME,AVG(SAL) AS "AVG_SAL_OF_EACH_DEPT"
FROM EMP JOIN DEPT ON  EMP.DEPTNO=DEPT.DEPTNO
GROUP BY DNAME 

					 
--12. Select the minimum and maximum salary from employee table.
--SOLUTION

SELECT MIN(SAL) AS "MINIMUM_SALARY",MAX(SAL) AS "MAXIMUM_SALARY"
FROM EMP	

--13. Select the minimum and maximum salaries from each department in employee table.
--SOLUTION

SELECT MIN(SAL) AS "MINIMUM_SALARY",MAX(SAL) AS "MAXIMUM_SALARY",DNAME
FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO
GROUP BY DNAME

--14. Select the details of employees whose salary is below 1000 and job is CLERK.
--SOLUTION

SELECT *
FROM EMP
WHERE JOB='CLERK' AND SAL < 1000