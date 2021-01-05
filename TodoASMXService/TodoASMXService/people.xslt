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
            <th>Name</th>
            <th>Phone</th>
            <th>Department ID</th>
            <th>Street</th>
            <th>City</th>
            <th>State</th>
            <th>ZipCode</th>
            <th>Country</th>
          </tr>
        </thead>

        <xsl:for-each select ="peoples/people">
          <tr>
            <td>
              <xsl:value-of select = "Name"/>
            </td>
            <td>
              <xsl:value-of select = "Phone"/>
            </td>
            <td>
              <xsl:value-of select = "Department"/>
            </td>
            <td>
              <xsl:value-of select = "Street"/>
            </td>
              <td>
              <xsl:value-of select = "City"/>
            </td>
              <td>
              <xsl:value-of select = "State"/>
            </td>
              <td>
              <xsl:value-of select = "ZipCode"/>
            </td>
             <td>
              <xsl:value-of select = "Country"/>
            </td>
          </tr>

        </xsl:for-each>
      </table>
    </xsl:copy>
  </xsl:template>
</xsl:stylesheet>
