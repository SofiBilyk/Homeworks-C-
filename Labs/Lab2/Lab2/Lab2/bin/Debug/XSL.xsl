<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet
				xmlns:xsl = "http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:output method = "html" />
	<xsl:template match = "DataBase">
		<html>
			<body>
				<table border = "3">
					<tr>
						<xsl:for-each select = "//section">
							<tr>
								<td>
									<table border = "2" width = "1200">
										<th style="width:10%;">
											<p align="left">Section</p>
										</th>
										<th style="width: 90%;">
											<p align="left"><xsl:value-of select = "@SECTION"></p>
										</th>
									</table>
								</td>
								<xsl:for-each select = "visitor">
									<tr>
										<td>
											<table border = "5" width = "1200">
												<tr>
										<th style="width:10%;">
											<p align="left">Visitor</p>
										</th>
										<th style="width: 90%;">
											<p align="left"><xsl:value-of select = "@VISITOR"></p>
										</th>
											</tr>
									</table>
										</td>
											
											<xsl:for-each select="sportsman">
											<tr>
												<td>
													<table border = "5" width = "1200">
														<tr>
															<th style="width:10%;">
																<p align="left">Name</p>
															</th>
															<th style="width: 90%;">
																<p align="left"><xsl:value-of select = "@NAME"></p>
															</th>
														</tr>
													</table>
												</td>
											</tr>
												
												
											<tr>
												<td>
													<table border = "5" width = "1200">
														<tr>
															<th style="width:10%;">
																<p align="left">Surname</p>
															</th>
															<th style="width: 90%;">
																<p align="left"><xsl:value-of select = "@SURNAME"></p>
															</th>
														</tr>
													</table>
												</td>
											</tr>
												
											<tr>
												<td>
													<table border = "5" width = "1200">
														<tr>
															<th style="width:10%;">
																<p align="left">Faculty</p>
															</th>
															<th style="width: 90%;">
																<p align="left"><xsl:value-of select = "@FACULTY"></p>
															</th>
														</tr>
													</table>
												</td>
											</tr>
												
											<tr>
												<td>
													<table border = "5" width = "1200">
														<tr>
															<th style="width:10%;">
																<p align="left">Schedule</p>
															</th>
															<th style="width: 90%;">
																<p align="left"><xsl:value-of select = "@SCHEDULE"></p>
															</th>
														</tr>
													</table>
												</td>
											</tr>
												
											<tr>
												<td>
													<table border = "5" width = "1200">
														<tr>
															<th style="width:10%;">
																<p align="left">Competition</p>
															</th>
															<th style="width: 90%;">
																<p align="left"><xsl:value-of select = "@COMPETITION"></p>
															</th>
														</tr>
													</table>
												</td>
											</tr>
											</xsl:for-each>
									</tr>
								</xsl:for-each>
									
							</tr>
						</xsl:for-each>
					</tr>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>