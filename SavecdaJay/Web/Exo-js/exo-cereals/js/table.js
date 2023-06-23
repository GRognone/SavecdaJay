import { Cereales } from "./cereales.js"

class Table
{
    constructor(cerealeTable)
    {
        this.cereales = cerealeTable;
        this.tBody = document.getElementById("tableBody");
    }

    generateBody()
    {
        this.tBody.innerHTML=""
        for(let cereale of this.cereales.cerealesCollection)
        {
            let row = document.createElement('tr');
            row.className="tablebodyTr";
            this.tBody.appendChild(row);
            this.generateCell(row, cereale.id);
            this.generateCell(row, cereale.name);
            this.generateCell(row, cereale.calories);
            this.generateCell(row, cereale.protein);
            this.generateCell(row, cereale.sodium);
            this.generateCell(row, cereale.fiber);
            this.generateCell(row, cereale.carbo);
            this.generateCell(row, cereale.sugars);
            this.generateCell(row, cereale.potass);
            this.generateCell(row, cereale.vitamins);
            this.generateCell(row, cereale.rating);
            this.generateCell(row, cereale.ns);
            this.generateCellDell(row, "❌",cereale.id);

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
        cell.addEventListener("click", (e) => this.deleteCereale(e.target.dataset.id));
        row.appendChild(cell);
    }

    generateSelectNs(row,id)
    {
        cell.dataset.id = id;
        cell.addEventListener("click",(e) => this.selectNutiscoreCereale(e.target.dataset.id));
        row.appendChild(cell);
    }

    deleteCereale(id)
    {
        this.cereales.deleteCereale(id);
        this.generateBody();
    }
    
    
}

export{Table};