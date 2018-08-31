function listMovies() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var data = JSON.parse(this.responseText);
            data.Movies.Title.forEach(element => {
                var node = document.createElement("li");
                node.innerText = element;
                document.getElementById("movieList").appendChild(node)
            });
        }
    };
    xhttp.open("GET", "http://localhost:58356/API/Movies1", true);
    xhttp.send();
}
