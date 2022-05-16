--1. List all employees whose name begins with 'A'.
--solution

select ENAME
from emp
where ename like 'A%'

--2. Select all those employees who don't have a manager.
--solution

select ENAME
FROM EMP
WHERE MGR=NULL

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
--SOLUTION

SELECT ENAME,EMPNO, SAL
FROM EMP
WHERE SAL BETWEEN 1200 AND 1400

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.
--SOLUTION

Select DNAME,ENAME,job,SAL ,SAL+SAL*0.1 as "10%_PAY_RISE"
 from EMP join DEPT on EMP.deptno=DEPT.DEPTNO 
 WHERE DEPT.dname='RESEARCH'

--5. Find the number of CLERKS employed. Give it a descriptive heading.
--SOLUTION

SELECT COUNT(JOB) AS NO_OF_CLERKS
FROM EMP
WHERE JOB = 'CLERK'
 
 --6. Find the average salary for each job type and the number of people employed in each job
 --SOLUTION

 SELECT JOB, AVG(SAL) AS AVG_SAL,COUNT(JOB) AS NO_OF_EMPLOYEES
 FROM EMP
 GROUP BY JOB

 --7. List the employees with the lowest and highest salary.
 --SOLUTION

 SELECT MIN(SAL) AS "LOWEST_SALARY" , MAX(SAL) AS "HIGEST_SALARY"
 FROM EMP

 --8. List full details of departments that don't have any employees. 
 --SOLUTION

 Select * From DEPT
WHERE DEPTNO NOT IN (SELECT DEPTNO FROM EMP)

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
--SOLUTION

SELECT ENAME, SAL
FROM EMP 
WHERE SAL >1200 AND JOB='ANALYST' AND DEPTNO=20
ORDER BY ENAME ASC

--10. For each department, list its name and number together with the total salary paid to employees in that department. 
--SOLUTION

SELECT JOB ,DEPTNO, SUM(SAL) AS "TOTAL_SAL" 
FROM EMP
GROUP BY DEPTNO,JOB

--11. Find out salary of both MILLER and SMITH.
--SOLUTION

SELECT ENAME,SAL 
FROM EMP
 WHERE ENAME IN ('MILLER','SMITH')

 --12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.
 --SOLUTION

SELECT ENAME  
FROM EMP
WHERE ENAME LIKE 'A%' Or ENAME LIKE 'M%'

--13. Compute yearly salary of SMITH.
--SOLUTION

SELECT SAL*12 AS "ANNUAL" 
FROM EMP
WHERE ENAME ='SMITH'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
--SOLUTION

SELECT ENAME,SAL 
FROM EMP
WHERE SAL BETWEEN 1500 AND 2850
