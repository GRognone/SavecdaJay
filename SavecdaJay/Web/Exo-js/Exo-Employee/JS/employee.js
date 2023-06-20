class Employee
{
    constructor(employee)
    {
    Object.assign(this,employee);
    this.email= this.generateEmail();
    this.yearOfBirth = this.calculateYearOfBirth();
    this.monthlySalary = this.calculateMonthSalary(); 
    }

    // generer Email
    generateEmail()
    {
        let name = this.employee_name.split(' ');
        let firstLetter = this.employee_name[0];
        let lastName = name[1];
        
        return (firstLetter + "." + lastName + "@email.com").toLocaleLowerCase();
    }

    // calculer annee de naissance
    calculateYearOfBirth()
    {
        let date = new Date().getFullYear();
        let yearOfBith = date - this.employee_age; 
        
        return yearOfBith;
    }

    // calculer salaire mensuel
    calculateMonthSalary()
    {
        let monthlySalary = this.employee_salary/12;

        return monthlySalary.toFixed(2); //pour prend le nombre, le transforme en string, et ne garde que 2 décimales après la virgule
    }

}
export{Employee};