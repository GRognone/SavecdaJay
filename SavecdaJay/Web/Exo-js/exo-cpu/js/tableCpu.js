class TableCpu{

    constructor(cpuTable)
    {
        this.tableCpuCollection = cpuTable;
        this.tbody = document.getElementById("tableBody");
        this.nbElement = document.getElementById("nbElement");
    }

    generateTable()
    {
        this.generateBody();
        this.nbElement.innerText = this.tableCpuCollection.cpusCollection.length;
    }

    generateBody()
    {
        let array = this.tableCpuCollection.cpusCollection;
        this.tbody.innerHTML=""

        for(let processor of array){
            let row = document.createElement('tr');
            row.className ="tableBodyTr";
            this.tbody.appendChild(row);
            this.generateCell(row,processor.id);
            this.generateCell(row,processor.brand);
            this.generateCell(row,processor.family);
            this.generateCell(row,processor.model);
            this.generateCell(row,processor.ghz);
            this.generateCell(row,processor.price);
            this.generateCell(row,processor.name);
        }
    }

    generateCell(row,processor){
        let cell = document.createElement('td');
        cell.ClassName="cellData";
        cell.textContent = processor;
        cell.dataset.value = processor;
        row.appendChild(cell);
    }

}
export{ TableCpu }