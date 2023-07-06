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
        generateCell(row,data)
    }

    countElement()
    {
        this.nbElement.innerHTML = this.cerealsCollection.data.length + "Elements";
    }
    calcAvgCal(){
        const length = this.cerealsCollection.data.length;
        this.caloriesAverage.innerHTML= "Moyenne Calories <br>" + this.cerealsCollection.data.reduce((acc, val) => {
            return acc + (val.calories/length);
        }, 0).toFixed(0);
        generateCell(row,data)
     };

}

export{Table};