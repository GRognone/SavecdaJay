import { CpuCollection } from "./cpuCollection.js";
import { TableCpu } from "./tableCpu.js";

let cpusCollection = new CpuCollection();
await cpusCollection.loadData();

let tableCpu = new TableCpu(cpusCollection);

tableCpu.generateTable();

// tri par prix
document.getElementById("price").addEventListener("clic",(e) =>{tableCpu.generateTable(cpusCollection.sortByPrice())});

// recherche par nom

document.getElementById("name").addEventListener("input", async (e)=>{
    let search = e.target.value
    await cpusCollection.searchByName(search);
    tableCpu.generateTable();
})



