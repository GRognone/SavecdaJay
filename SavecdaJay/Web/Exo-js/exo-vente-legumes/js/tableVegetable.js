class TableVegetable {

    constructor(_vegetablesCollection) {
        this.vegetablesCollection = _vegetablesCollection;
        this.tbody = document.querySelector('#tbody');
    }

    generateTable() {
        this.tbody.innerHTML = "";
        for (let vegetable of this.vegetablesCollection.initialCollection) {
            let trTemp = this.generateRow(vegetable)
            this.tbody.appendChild(trTemp);
        }
    }

    generateRow(vegetable) {
        let tr = document.createElement("tr");
        for (let val of vegetable.getValues()) {
            let cellTemp = this.generateCell(val);
            tr.appendChild(cellTemp);
        }
        return tr;
    }

    generateCell(value) {
        let td = document.createElement("td");
        td.textContent = value;
        td.classList.add("valuelistTableVegetables");
        return td;
    }
}

export { TableVegetable }