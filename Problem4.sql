/*Write SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six
alphabets.
*/
select * from Worker where FIRST_NAME like '%h' and LEN(FIRST_NAME)=6

/*2- Write SQL query to fetch worker names with salaries >= 50000 and <= 100000. */
select * from Worker where SALARY between 50000 and 100000

/*3- Write SQL query to fetch the no. of workers for each department in the descending order.*/
select department,count(*) WorkerNO from Worker group by department order by WorkerNO desc

/*4- Write SQL query to print details of the Workers who are also Managers. */
select * from Worker inner join 
Title on Title.WORKER_REF_ID=Worker.WORKER_ID
left join Bonus on Bonus.WORKER_REF_ID=Worker.WORKER_ID
where worker_title='Manager'

/*5- Write SQL query to show the second highest salary.*/
select top 1 FIRST_NAME,LAST_NAME, W.DEPARTMENT,SALARY from   Worker W where salary< 
(select max(salary) as MAXSAL from Worker )
order by SALARY desc

/*6- Write SQL query to print the name of employees having the highest salary in each department*/
select FIRST_NAME,LAST_NAME, W.DEPARTMENT,SALARY from   Worker W Inner JOIN 
(select department, max(salary) as MAXSAL from Worker group by DEPARTMENT) T 
on T.DEPARTMENT=W.DEPARTMENT and T.MAXSAL=W.SALARY
