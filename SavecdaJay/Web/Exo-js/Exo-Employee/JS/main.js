import { Employees } from "./employees.js";
import { TableGenerator } from "./tableGenerator.js"

let employee = new Employees();
await employee.getEmployees();
console.log(employee.employeesCollection);


let employeeTable = new TableGenerator(employee);
employeeTable.generateBody();

//recuperation du bouton
 const sortButton = document.getElementById('sortSalary');

 // puis ajout d'un élémént
 sortButton.addEventListener("click",() =>{
    employee.sortBySalary();
    employeeTable.generateBody();
});

