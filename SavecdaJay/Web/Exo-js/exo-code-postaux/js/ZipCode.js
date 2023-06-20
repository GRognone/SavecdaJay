ZipCodes()
//telecharger une ressource distante par l'API fech de javascript
fetch('https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json');
.then(r=> r.json())
.then(console.log())
class ZipCode
{
    constructor()
    {
        this.datasource="https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json";
        this.zipcode = [];
    }

   async load(){
    try{
        let response = await fetch(this.datasource);
        this.zipcodes = await response.json();
        console.log(this.zipcodes)
        console.log(this.zipcodes[0]);
    }
    catch(error){
        //traitement de l'erreur
    }
   }

   search(zipcode)
   {
    let result =[];
   }
}
search(zipcode)
{
    let result = [];
    result = this.zipcodes.filter(city => city.codePostal == zipcode);
    console.log(result);
    this.fillUi(result);
}

fillUi(result)
{
    // let element = document.getElementById('result');
    let element = document.querySelector('result');
    element.innerHTML = "";

    for(let city of result)
    {
        let li = document.createElement('li');
        li.innerText = city.nomCommune;
        element.appendChild(li);
    }
}
