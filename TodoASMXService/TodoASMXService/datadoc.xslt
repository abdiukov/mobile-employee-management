<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/ | node()">
    <xsl:copy>
      <table class ="table table-striped">
        <thead class ="thead-dark">
          <tr>
            <th>ID</th>
            <th>Department name</th>

          </tr>
        </thead>
			  <xsl:for-each select ="datas/data">
				  <tr>
					  <td>
						  <xsl:value-of select = "@id"/>
					  </td>
					  <td>
						  <xsl:value-of select = "name"/>
					  </td>
				  </tr>
        </xsl:for-each>
      </table>
    </xsl:copy>
  </xsl:template>
</xsl:stylesheet>
