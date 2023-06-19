import { Employees } from "./employees.js";
import { TableGenerator } from "./tableGenerator.js"

let employee = new Employees();
await employee.getEmployees();
console.log(employee.employeesCollection);


let employeeTable = new TableGenerator(employee)
employeeTable.generateBody();

const sort

