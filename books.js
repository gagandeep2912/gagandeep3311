function addbooks(){
    const book=document.getElementById("connect");
    const add=document.getElementById("add");
    add.innerHTML+="<li>"+book.value+"</li>"
}