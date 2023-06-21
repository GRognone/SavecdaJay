class ZipCode
{
    // Constructeru JavaScript
    constructor()
    {
        this.datasource = "https://arfp.github.io/tp/web/frontend/zipcodes/zipcodes.json";
        this.zipcodes = [];
    }

    //Charge des données distantes et le stocke dasn l'attribut this.zipcodes
    async load() {
        try{
            let response = await fetch(this.datasource);
            this.zipcodes = await response.json();
            console.log(this.zipcodes);// recupère un tableau de données
            console.log(this.zipcodes[0]) // prends 1 objet de la collection
        } catch(error){
            //traitement de l'erreur
        }
    }
    // Recherche des élements dans la collection this.ZipCodes
    search(zipcode)
    {
        let result = [];
        
    /* correspond à l'utilisation de la commande filter en dessous
            for(let city of this.zipcodes){
                if(city.codePostal == zipcode)
                {
                    result.push(city);
                    console.log(result);
                }
            }
    */
        result = this.zipcodes.filter(city => city.codePostal == zipcode);
        console.log(result);
        this.fillUi(result);
    }

    fillUi(result)
    {
        // let element = document.getElementById('result');
        let element = document.querySelector('#result');
        element.innerHTML = ""; // réinitialisation du contenu

        for(let city of result) {

            let li = document.createElement('li');//creation de l'élément <li>
            li.innerText = city.nomCommune;// ajout du conteny dans l'element <li>créé
            element.appendChild(li);// ajour de l'élémént <li> créé
        }
    }
}
export { ZipCode };