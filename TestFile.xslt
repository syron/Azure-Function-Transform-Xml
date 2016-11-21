<?xml version="1.0"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
  <body>
    <h2>People</h2>
    <table>
      <tr>
        <th>Name</th>
        <th>Email</th>
      </tr>
      <xsl:for-each select="Persons/Person">
        <tr>
          <td><xsl:value-of select="Name"/></td>
          <td><xsl:value-of select="Email"/></td>
        </tr>
      </xsl:for-each>
    </table>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>