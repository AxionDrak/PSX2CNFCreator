
== PSX/2 CNF Creator ==

PSX/2 CNF Creator v1.3
Novembro 17, 2019
by Axion Drak (laetemn@hotmail.com)


== Sobre ==
PSX/2 CNF Creator é uma pequena ferramenta para criar arquivos SYSTEM.CNF compatíveis com os 
consoles PSOne (PS1) e PSTwo (PS2), sendo usado principalmente para homebrews no disco.


== Recursos == 
* Capacidade de criar o arquivo SYSTEM.CNF compatível com PSOne e PSTwo:

  Suporta qualquer arquivo ELF (PSOne e PSTwo)
  Suporta inclusão de versão de arquivos e programas (PSTwo)
  Suporta modos de vídeo PAL e NTSC (PSTwo)
  Suporta HDDUNITPOWER nos modos NENHUM, HDD, NIC e NICHDD (PSTwo)
  Suporta TCB (PSOne)
  Suporta EVENT (PSOne)
  Suporta STACK (PSOne)
 
* Capacidade de criar arquivos Dummy (gargabe)
* Corrige automaticamente o formato do arquivo SYSTEM.CNF
* Opção LIMPAR adiciona como facilitdor
* Compatível com os seguintes sistemas operacionais: Windows 8/ 8.1 / 10


== SYSTEM.CNF ==
A estrutura do arquivo SYSTEM.CNF é diferente para os consoles PSOne e PSTwo.
Abaixo tem dois exemplos desse arquivo:

 - SYSTEM.CNF (PSOne)
	BOOT = cdrom:\MY_ELF.ELF;1
	TCB = 4
	EVENT = 16
	STACK = 801FFFFC

 - SYSTEM.CNF (PSTwo)
	BOOT2 = cdrom0:\MY_ELF.ELF;1
	VER = 1.00
	VMODE = NTSC
	HDDUNITPOWER = NIC (Opcional)


== Contato ==
A maneira mais fácil de entrar em contato com a equipe do PSX/2 CNF Creator é enviando 
relatórios de bugs. Você também pode enviar por e-mail para Axion Drak (laetemn@hotmail.com)


== Relatar Bugs ==
Verifique se o bug é reproduzível e ainda ocorre na versão mais recente do SVN/Daily build.

Verifique também a lista de problemas conhecidos (abaixo), para garantir que o problema ainda 
não seja conhecido:

Inclua as seguintes informações:
 - Versão PSX/2 CNF Creator (teste a versão mais recente do SVN/Daily build)
 - Detalhes do bug, incluindo instruções sobre a reprodução
 - Sistema operacional (Windows 8 / 8.1 / 10, ...)
 - Anexe uma imagem, se possível
 
== Problemas Conhecidos ==
 - Nenhum problema relatado :)

== Registro de Alterações / Changelog ==
v1.3
Novembro 18, 2019
 - Adicionado suporte a criação de arquivos Dummy (gargabe) para preencher discos CD/DVD

v1.2
Novembro 17, 2019
 - Adicionado suporte a opção de escolha do diretório para salvar o arquivo SYSTEM.CNF
 - Adicionada tela de informações sobre o programa
 - Adicionada opção de doações via PayPal ;)

v1.1
Novembro 16, 2019
 - Adicionado suporte completo ao SYSTEM.CNF para PSOne
 - Correções de estabilidade

v1.0 - RTM (Release To Manufaturing)
Novembro 15, 2019
 - Adicionado suporte ao HDDUNITPOWER (PSTwo)
 - Adicionada opção de resetar (LIMPAR) todas as configurações 

v0.50 - Versão RC (Release Candidate)
Novembro 14, 2019
 - Adicionado suporte completo ao SYSTEM.CNF para PSTwo
 - Correções de estabilidade

v0.10 - Versão Beta
Novembro 10, 2019
 - Liberação inicial BETA
