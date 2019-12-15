function getRandomInt1(max) {
  return 1 + Math.floor(Math.random() * Math.floor(max));
}
class voiture{
	constructor(id,nom,pht,pttc){
		this.id = id;
		this.nom = nom;
		this.pht = pht;
		this.pttc = pttc;
	}
}
class client{
	constructor(id,nom,prenom,ddn,adresse,cp,ville,tel){
		this.id = id;
		this.nom = nom;
		this.prenom = prenom;
		this.ddn = ddn;
		this.adresse = adresse;
		this.cp = cp;
		this.ville = ville;
		this.tel = tel;
	}
}
class vendeur{
	constructor(id,prenom){
		this.id = id;
		this.prenom = prenom;
	}
}
class commande{
	voitures = [];
	constructor(id,ref,vendeur,client,dc,dl){
		this.id = id;
		this.ref = ref;
		this.vendeur = vendeur;
		this.client = client;
		this.dc = dc;
		this.dl =dl;
	}
}
function createMooc()
{
	let voitures = [];
	for(let i = 0;i<42;++i)
	{
		let str = 'voiture '+i;
		let p1 = 1000*(i+1);
		let p2 = p1 + 0.2*p1;
		voitures.push(new voiture(i+1,str,p1,p2));
	}
	let clients = [];
	for(let i =0;i<10;++i)
	{
		let jj = getRandomInt1(30);
		let mm = getRandomInt1(12);
		let aa = 1979 + getRandomInt1(30);
		let dd = jj+'/'+mm+'/'+aa;
		let cp = 30000+i*1000;
		let  tel = "06 86 16 64 86";
		clients.push(new client(i+1,"nom "+i,"prenom "+i,dd,"adresse "+i,"ville "+i,cp,tel));
	}
	let vendeurs = [];
	vendeurs.push(new vendeur(1,"naoual"));
	vendeurs.push(new vendeur(2,"giscard"));
	vendeurs.push(new vendeur(3,"loic"));
	let commandes = [];
	for(let i=0;i<12;++i)
	{
		let id = i+1;
		let ref = "commande numero "+ id;
		let vendeurId = getRandomInt1(vendeurs.length);
		let clientId = getRandomInt1(clients.length);
		let jj = getRandomInt1(15);
		let mm = getRandomInt1(12);
		let aa = 2007 + getRandomInt1(10);
		let dc = jj+'/'+mm+'/'+aa; 	
		let jj2 = jj+getRandomInt1(15);
		let dl = jj2+'/'+mm+'/'+aa;
		commandes.push(new commande(i+1,ref,vendeurs[vendeurId-1],clients[clientId-1],dc,dl));
	}
	for(let i=0;i<5;++i)
	{
		commandes[0].voitures.push(voitures[i]);
	}
	for(let i=5;i<8;++i)
	{
		commandes[1].voitures.push(voitures[i]);
	}
	for(let i=8;i<12;++i)
	{
		commandes[2].voitures.push(voitures[i]);
	}
	for(let i=12;i<13;++i)
	{
		commandes[3].voitures.push(voitures[i]);
	}
	for(let i=13;i<19;++i)
	{
		commandes[4].voitures.push(voitures[i]);
	}
	for(let i=19;i<21;++i)
	{
		commandes[5].voitures.push(voitures[i]);
	}
	for(let i=21;i<23;++i)
	{
		commandes[6].voitures.push(voitures[i]);
	}
	for(let i=23;i<27;++i)
	{
		commandes[7].voitures.push(voitures[i]);
	}
	for(let i=27;i<30;++i)
	{
		commandes[8].voitures.push(voitures[i]);
	}
	for(let i=30;i<40;++i)
	{
		commandes[9].voitures.push(voitures[i]);
	}
	for(let i=40;i<41;++i)
	{
		commandes[10].voitures.push(voitures[i]);
	}
	for(let i=41;i<42;++i)
	{
		commandes[11].voitures.push(voitures[i]);
	}

	let str = JSON.stringify(voitures);
	localStorage.voitures = str;
	str = JSON.stringify(clients);
	localStorage.clients = str;
	str = JSON.stringify(vendeurs);
	localStorage.vendeurs = str;
	str = JSON.stringify(commandes);
	localStorage.commandes = str;
}

function loadMooc()
{
	if((localStorage.voitures==undefined)||
	   (localStorage.clients==undefined)||
	   (localStorage.vendeurs==undefined)||
	   (localStorage.commandes==undefined)){
		console.log("impossible de charger le mooc, il n'a pas été crée");
	}
	else
	{
		voitures = JSON.parse(localStorage.voitures);
		clients = JSON.parse(localStorage.clients);
		vendeurs = JSON.parse(localStorage.vendeurs);
		commandes = JSON.parse(localStorage.commandes);
	}
}
function deleteMooc(){

	if(localStorage.voitures!=undefined)
	{
		localStorage.removeItem(voitures);
	}
	if(localStorage.clients!=undefined)
	{
		localStorage.removeItem(clients);
	}
	if(localStorage.vendeurs!=undefined)
	{
		localStorage.removeItem(vendeurs);
	}
	if(localStorage.commandes!=undefined)
	{
		localStorage.removeItem(commandes);
	}
}


var voitures = [];
var clients = [];
var vendeurs = [];
var commandes = [];
//deleteMooc();
//createMooc();


$(document).ready(function(){
	loadMooc();
	console.log(commandes);
    for(var i=0;i<vendeurs.length;++i)
	{
		let str = '<option class="option-vendeur">'+vendeurs[i].prenom+'</option>';
		$('#select-vendeur').append(str);		
	}
	for(var i=0;i<clients.length;++i)
	{
		str = '<option class="option-client">'+clients[i].nom+'</option>';
		$('#select-client').append(str);
	}
});

function findVendeurByFirstname(prenom)
{
	let vendeur;
	for(let i=0;i<vendeurs.length;++i)
	{
		if(vendeurs[i].prenom==prenom)
		{
			vendeur = vendeurs[i];
			break;
		}
	}
	return vendeur;
}

function findClientByName(nom)
{
	let client;
	for(let i=0;i<clients.length;++i)
	{
		if(clients[i].nom==nom)
		{
			client = clients[i];
			break;
		}
	}
	return client;
}
function findCommandeByRef(ref)
{
	let commande;
	for(let i=0;i<commandes.length;++i)
	{
		if(commandes[i].ref==ref)
		{
			commande = commandes[i];
			break;
		}
	}
	return commande;
}

function changerParametres(){

	var prenomVendeur = $('#select-vendeur').val();
	var nomClient = $('#select-client').val();
	
	var tab = [];
	var str = '';

	if(prenomVendeur=="")
	{
		if(nomClient!="")
		{
			$('#select-commande option').remove();
			for(let i=0;i<commandes.length;++i)
			{
				if(i==0)
				{
					$('#select-commande').append('<option></option>');				
				}
				if(commandes[i].client.nom==nomClient)
				{
					str = '<option class="option-commande">'+commandes[i].ref+'</option>';
					$('#select-commande').append(str);		
				}
			}
		}
		else
		{
			$('#select-commande option').remove();
			$('#select-commande').append('<option></option>');
		}
	}
	else 
	{
		if(nomClient!="")
		{
			$('#select-commande option').remove();
			for(let i=0;i<commandes.length;++i)
			{
				if(i==0)
				{
					$('#select-commande').append('<option></option>');				
				}
				if((commandes[i].vendeur.prenom==prenomVendeur)&&(commandes[i].client.nom==nomClient))
				{
					str = '<option class="option-commande">'+commandes[i].ref+'</option>'; //
					$('#select-commande').append(str);		
				}
			}
		}
		else
		{
			console.log("toto");
			$('#select-commande option').remove();
			for(let i=0;i<commandes.length;++i)
			{
				if(i==0)
				{
					$('#select-commande').append('<option></option>');				
				}
				if(commandes[i].vendeur.prenom==prenomVendeur)
				{
					str = '<option class="option-commande">'+commandes[i].ref+'</option>';
					$('#select-commande').append(str);		
				}
			}
		}
	}
	infosCommande();
}

function changerVendeur(){

	changerParametres();
}

function changerClient(){
	var nomClient = $('#select-client').val();
	let client;

	changerParametres();

	if(nomClient==''){
		infosClient('','','','','','','');
	}
	else
	{
		client = findClientByName(nomClient);
		infosClient(client.nom,client.prenom,client.ddn,client.adresse,client.cp,client.ville,client.tel);
	}
}

function changerCommande(){
	var refCommande = $('#select-commande').val();;
	var tab = [];
	let commande;
	var str = '';

	if(refCommande=="")
	{
		infosCommande();
	}
	else
	{
		commande = findCommandeByRef(refCommande);
		console.log(refCommande);
		console.log(commande);
		infosCommande(commande);
	}
}

function infosClient(nom,prenom,ddn,adresse,cp,ville,tel)
{
	$('#nom').html(nom);
	$('#prenom').html(prenom);
	$('#ddn').html(ddn);
	$('#adresse').html(adresse);
	$('#cp').html(cp);
	$('#ville').html(ville);
	$('#tel').html(tel);
}

function infosCommande(commande)
{	
	let str;
	let totalHt = 0;
	let totalTtc = 0;
	if(commande==undefined)
	{
		$('#commande-ref').html('');
		$('#date-commande').html('');
		$('#date-livraison').html('');
		$('#commande-vendeur').html('');
		$('#commande-client').html('');
		//$('#table-tbody tr').remove();
	}
	else
	{
		$('#commande-ref').html(commande.ref);
		$('#date-commande').html(commande.dc);
		$('#date-livraison').html(commande.dl);
		$('#commande-vendeur').html(commande.vendeur.prenom);
		$('#commande-client').html(commande.client.nom);

		//$('#table-tbody tr').remove();

		for(let i=0;i<commande.voitures.length;++i)
		{
			str = '<tr><td>'+commande.voitures[i].nom+'</td><td>'+commande.voitures[i].pht+'</td><td>'+commande.voitures[i].pttc+'</td></tr>';
			$('#table-tbody').append(str);
			totalHt += commande.voitures[i].pht;
			totalTtc += commande.voitures[i].pttc;
		}

		str = " <tr style='font-weight: bold'><td>Total</td><td>"+totalHt+"</td><td>"+totalTtc+"</td></tr>";
		$('#table-tbody').append(str);
	}
	
}
/*function infosCommande(ref,vendeur,client,dc,dl)
{	
	$('#commande-ref').html(ref);
	$('#date-commande').html(dc);
	$('#date-livraison').html(dl);
	$('#commande-vendeur').html(vendeur);
	$('#commande-client').html(client);
	for(let i=0;i<voitures.length;++i)
	{
		$('#table-commande')
	}
}*/

/*
function changerVendeur(){

	var value = $('#select-vendeur').val();
	var tab = [];
	var str = '';

	if(value=="")
	{

		$('#select-client option').remove();
		$('#select-client').append('<option></option>');
	}
	else
	{
		if(value=="naoual")
		{
			tab = tabClientsNaoual;
		}
		else if(value=="giscard")
		{
			tab = tabClientsGiscard;
		}
		else if(value=="loic")
		{
			tab = tabClientsLoic;
		}
		
		$('#select-client option').remove();
		for(var i=0;i<tab.length;++i)
		{
			if(i==0)
			{
				$('#select-client').append('<option></option>');				
			}
			str = '<option class="option-client">'+tab[i].nom+'</option>';
			$('#select-client').append(str);
		}
	}

	infosClient('','','','','','','');
}

function changerClient(){

	var client = $('#select-client').val();
	var vendeur = $('#select-vendeur').val();
	var tab = [];

	if(client==''){
		infosClient('','','','','','','');
	}
	else
	{
		if(vendeur=="naoual")
		{
			tab = tabClientsNaoual;
		}
		else if(vendeur=="giscard")
		{
			tab = tabClientsGiscard;
		}
		else if(vendeur=="loic")
		{
			tab = tabClientsLoic;
		}

		var i = 0;
		do
		{
			if(tab[i].nom!=client)
			{
				i += 1;
			}
			else
			{
				break;
			}
		}while(i<tab.length);
		console.log(client);
		console.log(i);

		infosClient(tab[i].nom,tab[i].prenom,tab[i].ddn,tab[i].adresse,tab[i].cp,tab[i].ville,tab[i].tel);
	}
}

function changerCommande(){
	var value = $('#select-vendeur').val();
	var tab = [];
	var str = '';
}

function infosClient(nom,prenom,ddn,adresse,cp,ville,tel)
{
	$('#nom').html(nom);
	$('#prenom').html(prenom);
	$('#ddn').html(ddn);
	$('#adresse').html(adresse);
	$('#cp').html(cp);
	$('#ville').html(ville);
	$('#tel').html(tel);
}*/


/*if ( localStorage.voitures != undefined ){
        // je transforme ma chaine de caractere en Objet
        var voitures = JSON.parse(localStorage.voitures);
        console.log(localStorage.voitures);
        console.log(voitures);
    }else{
        console.log('RIEN');
    }
    if ( localStorage.clients != undefined ){
        // je transforme ma chaine de caractere en Objet
        var clients = JSON.parse(localStorage.clients);
        console.log(localStorage.clients);
        console.log(clients);
    }else{
        console.log('RIEN');
    }
    if ( localStorage.vendeurs != undefined ){
        // je transforme ma chaine de caractere en Objet
        var vendeurs = JSON.parse(localStorage.vendeurs);
        console.log(localStorage.vendeurs);
        console.log(vendeurs);
    }else{
        console.log('RIEN');
    }
    if ( localStorage.commandes != undefined ){
        // je transforme ma chaine de caractere en Objet
        var commandes = JSON.parse(localStorage.commandes);
        console.log(localStorage.commandes);
        console.log(commandes);
    }else{
        console.log('RIEN');
    }*/				