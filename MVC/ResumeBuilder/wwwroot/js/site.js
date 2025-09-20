// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
const dataRows = document.querySelectorAll(".grid-data");

dataRows.forEach((row) => {
    row.addEventListener("click", () => {
        rowData = row.querySelectorAll("td");

        document.querySelector("#name").value = rowData[0].innerHTML;
        document.querySelector("#age").value = rowData[1].innerHTML;
        document.querySelector("#email").value = rowData[2].innerHTML;
        document.querySelector("#phone").value = rowData[3].innerHTML;

        if (rowData[4].innerHTML === "Male")
            document.querySelector("#male").checked = true;
        else
            document.querySelector("#female").checked = true;

        document.querySelector("#address").value = rowData[5].innerHTML;
        document.querySelector("#summary").value = rowData[6].innerHTML;
        document.querySelector("#skills").value = rowData[7].innerHTML;
        document.querySelector("#degree").value = rowData[8].innerHTML;
        document.querySelector("#university").value = rowData[9].innerHTML;
        document.querySelector("#year").value = rowData[10].innerHTML;
        document.querySelector("#company").value = rowData[11].innerHTML;
        document.querySelector("#role").value = rowData[12].innerHTML;
        document.querySelector("#years").value = rowData[13].innerHTML;
    });
});