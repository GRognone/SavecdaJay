/*représente 1 seul vol*/
class Flight {
    constructor(flight) 
    {
        // clonage de l'objet reçu en paramètre dans l'objet courant
        // tous les attributs et leurs valeurs seront copiés !
        Object.assign(this, flight);
        this.travelTime = this.calculateTravelTime();
    }

    /**
         * Retourne les valeurs de l'objet courant dans un tableau indexé
         * @returns {Array} Les valeurs de l'objet dans un tableau indexé
         */
    getValues()
    {
        // crée un tableau indexé contenant les valeurs de l'objet fourni en paramètre
        return Object.values(this);
    }

    calculateTravelTime()
    {
        let time;
        let hours;
        let minutes;
        // floor troncature du resultat de la division de la valeur contenue dasn le flight_duration par 60
        hours = Math.floor(this.flight_duration / 60);
        minutes = this.flight_duration % 60;

        time = hours + ":" + minutes + ":00";

        return time;
    }

}
export { Flight }