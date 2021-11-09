<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0"
				xmlns:xsl = "http://www.w3.org/1999/XSL/Transform">
	<xsl:output method = "html"/>
	<xsl:template match="Dorms">
		<html>
		<body>
			<xsl:for-each select = "//Dormitory">
				<p align ="left"><b>
						Гуртожиток №<xsl:value-of select = "@Number"/>
				</b></p>
			<table border = "1" WIDTH ="1200">
				<TR>
					<th style ="width:20%;"> Студент </th>
					<th style ="width:20%;"> Факультет </th>
					<th style ="width:20%;"> Кафедра </th>
					<th style ="width:10%;"> Курс </th>
					<th style ="width:10%;"> Кімната </th>
					<th style ="width:20%;"> Період проживання </th>
				</TR>
				<xsl:for-each select = "Student">
					<tr>
						<td> <xsl:value-of select = "@Name"/>&#160;<xsl:value-of select = "@Surname"/>&#160;<xsl:value-of select = "@Patronymic"/> </td>
						<td> <xsl:value-of select = "@Faculty"/> </td>
						<td> <xsl:value-of select = "@Cathedra"/> </td>
						<td> <xsl:value-of select = "@Year"/> </td>
						<td> <xsl:value-of select = "@Room"/> </td>
						<td> <xsl:value-of select = "@InDate"/> - <xsl:value-of select = "@OutDate"/> </td>
					</tr>
				</xsl:for-each>
				
			</table>
			</xsl:for-each>
			
		</body>
		</html>
	
	</xsl:template>
</xsl:stylesheet>