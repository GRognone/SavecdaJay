import { Cereals } from "./cereals.js"

class Table
{
    constructor(cerealTable)
    {
        this.cereals = cerealTable;
        this.tBody = document.getElementById("tableBody");
        this.nbElement = document.getElementById("nbElement");
        this.caloriesAverage = document.getElementById("caloriesAverage");
    }

    generateTable(array=this.cereals.cerealsCollection){
        this.generateBody(array);

        // compte du nombre d'element cereal
        this.nbElement.innerText = array.length +" Elements";
        
        // calcul de la moyenne des calories
        //etape 1 somme du nombre total de calories
        let calories = 0;
        array.forEach(myCereal => {
            calories += myCereal.calories;
        });
        //etape 2 calcul de la moyenne
        calories= Math.floor(calories/array.length);
        this.caloriesAverage.innerText = "Moyenne Calories " + calories 
    }

    generateBody(array=this.cereals.cerealsCollection)
    {
        this.tBody.innerHTML=""

        for(let cereal of array)
        {
            let row = document.createElement('tr');
            row.className="tablebodyTr";
            this.tBody.appendChild(row);
            this.generateCell(row, cereal.id);
            this.generateCell(row, cereal.name);
            this.generateCell(row, cereal.calories);
            this.generateCell(row, cereal.protein);
            this.generateCell(row, cereal.sodium);
            this.generateCell(row, cereal.fiber);
            this.generateCell(row, cereal.carbo);
            this.generateCell(row, cereal.sugars);
            this.generateCell(row, cereal.potass);
            this.generateCell(row, cereal.vitamins);
            this.generateCell(row, cereal.rating);
            this.generateCell(row, cereal.ns);
            this.generateCellDell(row, "❌",cereal.id);
        }

    }

    generateCell(row,data)
    {
        let cell = document.createElement('td');
        cell.className="cellData";
        cell.textContent = data;
        cell.dataset.val = data;
        row.appendChild(cell);
    }

    generateCellDell(row,data,id)
    {
        let cell = document.createElement('td');
        cell.className="cellData"
        cell.textContent = data;
        cell.dataset.val = data;
        cell.dataset.id = id;
        cell.addEventListener("click", (e) => this.deleteCereal(e.target.dataset.id));
        row.appendChild(cell);
    }
    
    deleteCereal(id)
    {
        this.cereals.deleteCereal(id);
        this.generateBody();
    }

    

}

export{Table};