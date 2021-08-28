function Out-Voice
{
  <#
    .SYNOPSIS
    Sends text to the text-to-speech engine. Make sure your volume is turned up.

    .DESCRIPTION
    Uses the built-in text-to-speech engine to convert text to speech.

    .EXAMPLE
    Out-Voice -Text 'Hello World'
    Speaks: "Hello World!" 

    .EXAMPLE
    Out-Voice -Text 'Hello World' -Rate -10
    Speaks: "Hello World!" very slowly. Allowable speed rates are -10 to 10.

    .EXAMPLE
    Get-Content -Path c:\text.txt | Out-Voice
    reads each line of the text file

    .LINK
    https://powershell.one
  #>


  param
  (
    [String]
    [Parameter(Mandatory, ValueFromPipeline)]
    $Text,
    
    [int]
    [ValidateRange(-10,10)]
    $Rate = 0
  )
    
  begin
  {
    $tts = New-Object -ComObject Sapi.SpVoice -Property @{
      Rate = $Rate
    }
  }
    
  process
  {
    $null = $tts.Speak($Text)
  }
}