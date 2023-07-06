class Flight 
{
    constructor(flight) 
    {
        Object.assign(this, flight);
        this.travelTime = this.calculateTravelTime();
}
    calculateTravelTime()
    {
        let time;
        let hours;
        let minutes;
      // floor troncature du resultat de la division de la valeur contenue dasn le flight_duration par 60
        hours = Math.floor(this.flight_duration / 60);
        minutes = this.flight_duration%60;

        time = hours+":"+ minutes + ":00";

        return time; 
    }

}
export {Flight}