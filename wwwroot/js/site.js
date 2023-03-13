// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
<script type="text/jscript">
{
function GetFileSize(fileid)
{
 var fileSize = 0;
 //for IE
 if ($.browser.msie)
 {
     {
 toString (objFSO = new ActiveXObject("Scripting.FileSystemObject"))
 {
 var filePath = $("#" + fileid)[0].value;
 var objFile = objFSO.getFile(filePath);
 var fileSize = objFile.size; //size in kb
 fileSize = fileSize / 1048576; //size in mb
 } 
}
 
 else
 {
 fileSize = $("#" + fileid)[0].files[0].size //size in kb
 fileSize = fileSize / 1048576; //size in mb
 }
 return fileSize;
 }
 catch (e)
 {
 alert("Error is :" + e);
 }
}

//get file path from client system
function getNameFromPath(strFilepath)
{
 var objRE = new RegExp(/([^\/\\]+)$/);
 var strName = objRE.exec(strFilepath);

 if (strName == null)
 {
 return null;
 }
 else
 {
 return strName[0];
 }
}

$("#btnSubmit").live("click", function ()
{
 if ($('#fileToUpload').val() == "")
 {
 $("#spanfile").html("Please upload file");
 return false;
 }
 else
 {
 return checkfile();
 }
});

function checkfile()
{
 var file = getNameFromPath($("#fileToUpload").val());
 if (file != null)
 {
 var extension = file.substr((file.lastIndexOf('.') + 1));
 // alert(extension);
 switch (extension) {
 case 'jpg':
 case 'png':
 case 'gif':
 case 'pdf':
 flag = true;
 break;
 default:
 flag = false;
 }
 }
 if (flag == false)
 {
 $("#spanfile").text("You can upload only jpg,png,gif,pdf extension file");
 return false;
 }
 else
 {
 var size = GetFileSize('fileToUpload');
 if (size &gt 3)
 {
 $("#spanfile").text("You can upload file up to 3 MB");
 (return false;);
 
 else
 {
 $("#spanfile").text("");
 }
 }
}
$(function ()
{
 $("#fileToUpload").change(function () {
 checkfile();});
});
</script>