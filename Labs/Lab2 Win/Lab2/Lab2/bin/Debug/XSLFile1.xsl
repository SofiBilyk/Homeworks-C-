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
								<xsl:value-of select="@SECTION">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@STATUS">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@NAME">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@SURNAME">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@SCHEDULE">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@COMPETITIONS">
								</xsl:value-of>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>