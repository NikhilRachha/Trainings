import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angular_assignment';
  EmployeeId:number=1;
  EmployeeName:string="Nikhil";
  EmployeeJob:string="Manager";
  EmployeeSalary:number=75000;
  EmployeeDeptno:number=10;
  Depts:any[]=[
    {Deptno:"10",Dname:"Sales",loc:"Hyd"},
    {Deptno:"20",Dname:"Finance",loc:"Pune"},
    {Deptno:"30",Dname:"Audit",loc:"Hyd"},
    {Deptno:"40",Dname:"Consulting",loc:""},
    {Deptno:"50",Dname:"Tax",loc:"Pune"},
    {Deptno:"60",Dname:"Risk",loc:"Mum"},
    {Deptno:"70",Dname:"Operations",loc:"Pune"},
    {Deptno:"80",Dname:"Accounts",loc:"Hyd"},
    {Deptno:"90",Dname:"Finance",loc:"Pune"},
    {Deptno:"100",Dname:"Audit",loc:"Hyd"}
  ]
}
