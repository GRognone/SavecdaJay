import { Db } from "./db.js";
import { Employee} from "./employee.js"

class Employees 
{
    constructor()
    {
        this.employeesCollection = [];
        this.sortOrder = true;// true ordre croissant - false ordre décroissant
   
    }

    async getEmployees()
    {
        let employeeToAdd = await Db.fetchData('https://arfp.github.io/tp/web/frontend/employees/employees.json');
        for(let employee of employeeToAdd.data)
        {
            this.employeesCollection.push(new Employee(employee));
        }

        return this.employeesCollection;
    }

    // methode qui supprime l'employé par son identifiant

    deleteEmployee(id)
    {
        this.employeesCollection = this.employeesCollection.filter(emp => emp.id!=id)
    }

    // methode pour dupliquer employé
    duplicateEmployee(id)
    {
        let employee = this.employeesCollection.find(emp => emp.id==id);

        let maxId = Math.max.apply(Math, this.employeesCollection.map(function(emp){return emp.id})); //map(funcion(recupère l'employé){return retourne son identifiant})

        if(employee instanceof Employee)
        {
            let newEmployee = new Employee(employee) // création d'un nouvel employé à partir de la création de l'employé original
            newEmployee.id = ++ maxId;
            // newEmployee.id = max +1;  équivalent à la ligne precedente
            this.employeesCollection.push(newEmployee);
        }
    }

    sortBySalary()
    {
        //tri du tableau par salaire
        this.employeesCollection.sort((a , b) => a.employee_salary - b.employee_salary);

        //tri dans l'ordre
        if (!this.sortOrder)
        {
            this.employeesCollection.reverse();
        }
        //pour inverser l'ordre du tri si l'on re-click sur le bouton de tri
        this.sortOrder = !this.sortOrder;
    }

}

export {Employees};