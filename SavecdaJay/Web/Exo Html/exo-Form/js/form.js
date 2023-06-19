let dateControl = document.querySelector('#DateTime');
console.log(dateControl)
let today=new Date()
let monthPrefix = today.getMonth() < 9 ? "0" : "";
let todayString = today.getFullYear() + "-" + monthPrefix + (today.getMonth()+1) + "-" + today.getDate();
console.log(today)
dateControl.min = todayString;