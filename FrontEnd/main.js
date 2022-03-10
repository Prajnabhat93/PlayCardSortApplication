const txt = document.getElementById("cardinput");
const btn = document.getElementById("sortbtn");
const out = document.getElementById("output");
//var data = ["3D","4T","2S","QD","AD","RT","9H","AS","5C","9D","7C"]
var data = ["3C", "JS", "2D", "PT", "10H", "KH", "8S", "4T", "AC", "4H", "RT" ]

console.log(data);

btn.addEventListener("click", fun1);

function fun1()
{

    fetch('https://localhost:5001/api/CardsSort', {
        method: 'POST', 
        headers: {
        'Content-Type': 'application/json',
        },
        body: JSON.stringify(data),
        })
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            out.innerHTML = data ;
        })
        .catch((error) => {
        console.error('Error:', error);
    });  
}

