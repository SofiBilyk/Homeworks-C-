<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html"/>
	<xsl:template match="/">
		<html>
			<body>
				<table border="2">
					<TR>
						<th>Section</th>
						<th>Status</th>
						<th>Name</th>
						<th>Surname</th>
						<th>Schedule</th>
						<th>Competition</th>
					</TR>
					<xsl:for-each select="Sportsmans/Sportsman">
						<tr>
							<td>
								<xsl:value-of select="@Section">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Status">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Name">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Surname">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Schedule">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Competition">
								</xsl:value-of>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>