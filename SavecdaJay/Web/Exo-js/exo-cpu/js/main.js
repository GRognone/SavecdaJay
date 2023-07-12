import { CpuCollection } from "./cpuCollection.js";
import { TableCpu } from "./tableCpu.js";

let cpusCollection = new CpuCollection();
await cpusCollection.loadData();

let tableCpu = new TableCpu(cpusCollection);

tableCpu.generateTable();

// tri par prix
document.getElementById("price").addEventListener("click",(e)=> {tableCpu.generateTable(cpusCollection.sortByPrice())});


// recherche par nom

document.getElementById("search").addEventListener("input", async (e)=>{
    let searchFieldValue = e.target.value
    await cpusCollection.searchByName(searchFieldValue);
    tableCpu.generateTable();
})



